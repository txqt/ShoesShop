﻿using Microsoft.AspNetCore.Http;
using PoPoy.Shared.Common;
using PoPoy.Shared.Dto;
using PoPoy.Shared.Dto.RefreshToken;
using PoPoy.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoPoy.Api.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<bool>> Register(RegisterRequest request);
        Task<LoginResponse<AuthResponseDto>> Login(LoginRequest login);
        Task<ServiceResponse<string>> ForgetPassword(string email);
        Task<ServiceResponse<string>> ConfirmEmail(string userId, string token);
        Task<ServiceResponse<string>> ResetPassword(ResetPasswordRequest model);
        Task<ServiceResponse<string>> ChangePassword(ChangePasswordRequest model);
        Task<ServiceResponse<bool>> RoleAssign(Guid id, RoleAssignRequest request);
        Task<List<UserVM>> GetUserPaging();
        Task<List<Address>> GetListAddress();
        Task<List<RoleVM>> GetAllRoles();
        Task<Guid> GetUserId(LoginRequest request);
        Task<List<User>> SearchUser(string searchText);
        Task<ServiceResponse<UserVM>> GetById(Guid id);
        Task<UserVM> GetUserById(Guid id);
        Task<ServiceResponse<bool>> DeleteUser(Guid id);
        Task<ServiceResponse<bool>> UpdateUser(Guid id, UserUpdateRequest request);
        Task<ServiceResponse<bool>> CreateUser(CreateUser request);
        Task<ServiceResponse<User>> GetUserFromId(string idUser);
        Task<string> MakePaymentPaypal(double total);
        Task<bool> UpdatePaymentStatus(Guid userId);
        string MakePaymentVNPay(double total);
        Task<string> CheckOut(List<Cart> cartItem);
        Task<bool> CreateAddress(Address address);
        Task<ServiceResponse<Address>> AddOrUpdateAddress(Address address, Guid userId);
        Task<ServiceResponse<Address>> GetAddress(Guid userId);
        Task<ServiceResponse<List<UploadResult>>> UploadUserImage(List<IFormFile> files, string userId);
        Guid UserId();
        Task<List<SelectItem>> GetShippers();
        Task<User> GetCurrentUserAsync();
        Task<ServiceResponse<bool>> UpdateUserProfile(User user);
        Task<bool> DeleteUserAvatar(string id);
        Task<bool> UpdatePaymentVnPayStatus(Guid userId);
    }
}
