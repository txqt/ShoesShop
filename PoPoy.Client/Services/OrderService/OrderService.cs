﻿using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using PoPoy.Client.Extensions;
using PoPoy.Client.Services.AuthService;
using PoPoy.Client.Services.HttpRepository;
using PoPoy.Shared.Dto;
using PoPoy.Shared.Entities;
using PoPoy.Shared.Paging;
using PoPoy.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PoPoy.Client.Services.OrderService
{
    public class OrderService : IOrderService, IDisposable
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;
        private readonly ILocalStorageService _localStorage;
        private readonly HttpInterceptorService httpInterceptorService;
        private readonly IAuthService authService;

        public OrderService(HttpClient http,
            AuthenticationStateProvider authStateProvider,
            NavigationManager navigationManager, ILocalStorageService localStorage,
            HttpInterceptorService httpInterceptorService,
            IAuthService authService)
        {
            _http = http;
            _navigationManager = navigationManager;
            this._localStorage = localStorage;
            this.httpInterceptorService = httpInterceptorService;
            this.authService = authService;
        }

        public PagingResponse<OrderOverviewResponse> ListOrderResponse { get; set; } = new PagingResponse<OrderOverviewResponse>();
        public OrderDetailsResponse ListOrderDetailsResponse { get; set; } = new OrderDetailsResponse();

        public event Action OrderDetailsChanged;
        public event Action OrderListChanged;

        public async Task<Refund> CancelOrder(string id)
        {
            var result = await _http.GetFromJsonAsync<Refund>($"/api/Order/cancel-order?id={id}");
            return result;
        }

        public void Dispose() => httpInterceptorService.DisposeEvent();

        public async Task GetOrderDetails(string? orderId)
        {
            if (orderId != null)
            {
                var result = await _http.GetFromJsonAsync<ServiceResponse<OrderDetailsResponse>>($"/api/Order/get-order-detail-user/{orderId}");
                if (!result.Success)
                {
                    throw new ApplicationException();
                }
                ListOrderDetailsResponse = result.Data;
            }
            OrderDetailsChanged.Invoke();
        }

        public async Task GetOrders(ProductParameters productParameters)
        {
            httpInterceptorService.RegisterEvent();
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = productParameters.PageNumber.ToString(),
                ["searchText"] = productParameters.searchText == null ? "" : productParameters.searchText,
                ["pageSize"] = productParameters.PageSize.ToString(),
                ["orderBy"] = productParameters.OrderBy
            };
            var response = await _http.GetAsync(QueryHelpers.AddQueryString($"/api/Order/get-all-order-user", queryStringParam));

            await response.CheckAuthorized(authService);

            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            ListOrderResponse.Items = JsonConvert.DeserializeObject<List<OrderOverviewResponse>>(content);

            ListOrderResponse.MetaData = JsonConvert.DeserializeObject<MetaData>(response.Headers.GetValues("X-Pagination").First());

            OrderListChanged.Invoke();
        }


        public async Task<Order> GetOrderWithUser(string orderId)
        {
            var result = await _http.GetFromJsonAsync<Order>($"/api/order/GetOrderWithUser/{orderId}");
            return result;
        }

        public async Task DeleteOrder(string orderId)
        {
            await _http.DeleteAsync($"/api/order/{orderId}");
        }

        public async Task SavePaymentUrl(string orderId, string url)
        {
            await _http.GetFromJsonAsync($"/api/order/saveUrl/?orderId={orderId}&url={url}", null);
        }
        public async Task<DistanceDto> DrivingDistancebyAddress(string address)
        {
            var result = await _http.GetFromJsonAsync<DistanceDto>($"/api/Order/DrivingDistancebyAddress?address={address}", null);
            return result;
        }
        public async Task<string> GetPaymentUrl(string orderId)
        {
            var url = await _http.GetStringAsync($"/api/order/getUrl/?orderId={orderId}");
            return url;
        }
    }
}
