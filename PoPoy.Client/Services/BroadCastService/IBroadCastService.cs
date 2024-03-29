﻿using Microsoft.AspNetCore.SignalR.Client;
using PoPoy.Shared.Dto;
using PoPoy.Shared.Dto.Chats;
using PoPoy.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PoPoy.Client.Services.BroadCastService
{
    public interface IBroadCastService
    {

        Task<ServiceResponse<List<NotificationDto>>> GetNotificationsByUserJwt();
        Task ReadNoti(Guid notiId);
        Task ReadAllNoti();
        Task SendNotiAllAdmin(NotiSendConfig dto);
        Task<string> GetUserIdCurrentChat();
        Task SendNotiUserId(NotiSendConfig dto, Guid UserId);

        Task SendNotiCurrentUser(NotiSendConfig config); // send cho chính mình 
        Task SendMessageAllAdmin(string message, string dataImgBase64 = null);
        Task<string> GetUserAvtChat();
        Task SendInfoOrderId(string orderId);
        Task SendInfoOrderModel(OrderDetailsProductResponse product, OrderDetailsResponse order);
        Task SendInfoOrderModelToUserId(Order order, Guid userId);
        Task SendInfoOrderModelAllAdmin(Order order);
        Task<ServiceResponse<List<ListChatUser>>> GetListChatUser();
        Task<ServiceResponse<List<ListChatSender>>> GetListChatSender();

        void SetHub(HubConnection hub);
        HubConnection BuidHubWithToken();
        Task StartAsync(HubConnection hubConnection);
    }
}
