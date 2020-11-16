﻿using ApiModels.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Interfaces
{
    public interface ITimeOffRequestService
    {
        Task <TimeOffRequestApiModel> AddAsync(TimeOffRequestApiModel obj);
        Task<IReadOnlyCollection<TimeOffRequestApiModel>> GetAllAsync(int userId, DateTime? startDate = null, DateTime? endDate = null, int? stateId = null, int? typeId = null);
        Task<TimeOffRequestApiModel> GetByIdAsync(int requestId);
        Task<TimeOffRequestApiModel> GetByIdAsync(int userId, int requestId);
        Task UpdateAsync(int userId, TimeOffRequestApiModel newModel);
        Task DeleteAsync(int requestId);

        Task RejectedByOwnerAsync(int userId, int requestId);
    }
}
