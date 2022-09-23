﻿using Blazored.LocalStorage;
using PoPoy.Client.Services.ProductService;
using PoPoy.Client.State;
using PoPoy.Shared.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoPoy.Client.Services.CartService
{
    public interface ICartService
    {
        ValueTask UpdateAsync(CartStorage cartStorage);
        ValueTask AddAsync(CartStorage cartStorage);
        ValueTask RemoveAsync(int productId);
        ValueTask RemoveAllAsync();
        ValueTask<List<Cart>> GetAllAsync();
    }

    public class CartService : ICartService
    {
        private const string CART = "cart";

        private readonly ILocalStorageService storageService;
        private readonly IProductService publicProductService;
        private readonly ICartState cartState;

        public CartService(ILocalStorageService storageService, IProductService publicProductService,
            ICartState cartState)
        {
            this.storageService = storageService;
            this.publicProductService = publicProductService;
            this.cartState = cartState;
        }

        private async ValueTask UpdateCartStorage(CartStorage cart, CartStorageType type)
        {
            var storages = await storageService.GetItemAsync<List<CartStorage>>(CART)
                           ?? new List<CartStorage>();

            var storage = storages.Find(x => x.ProductId == cart.ProductId);
            if (storage is null)
            {
                if (type is not CartStorageType.Remove)
                {
                    storages.Add(cart);
                    await storageService.SetItemAsync(CART, storages);
                }
                await cartState.UpdateAsync();
                return;
            }

            switch (type)
            {
                case CartStorageType.Add:
                    storage.Quantity += cart.Quantity;
                    break;
                case CartStorageType.Update:
                    storage.Quantity = cart.Quantity;
                    break;
                case CartStorageType.Remove:
                    storages.Remove(storage);
                    break;
                default:
                    break;
            }

            await storageService.SetItemAsync(CART, storages);
            await cartState.UpdateAsync();
        }

        public async ValueTask AddAsync(CartStorage cart)
            => await UpdateCartStorage(cart, CartStorageType.Add);

        public async ValueTask UpdateAsync(CartStorage cart)
            => await UpdateCartStorage(cart, CartStorageType.Update);

        public async ValueTask RemoveAsync(int productId)
            => await UpdateCartStorage(new CartStorage { ProductId = productId }, CartStorageType.Remove);

        public async ValueTask RemoveAllAsync()
        {
            await storageService.RemoveItemAsync(CART);
            await storageService.SetItemAsync(CART, new List<CartStorage>());
            await cartState.UpdateAsync();
        }

        public async ValueTask<List<Cart>> GetAllAsync()
        {
            var storages = await storageService.GetItemAsync<List<CartStorage>>(CART);
            if (storages is null)
            {
                await storageService.SetItemAsync(CART, new List<CartStorage>());
                return new List<Cart>();
            }
                

            var products = await publicProductService.FilterAllByIdsAsync(storages.Select(x => x.ProductId).ToArray());

            return products.Select(p => new Cart
            {
                Quantity = storages.FirstOrDefault(s => s.ProductId == p.Id).Quantity,
                Product = p
            }).ToList();
        }
    }
}



