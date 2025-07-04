﻿using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.Recipe;

namespace Jantuscara.Application.Interfaces.UseCases.Recipe
{
    public interface IUpdateRecipeUseCase
    {
        Task<IMessageResponse> ExecuteAsync(UpdateRecipeDto dto);
    }
}
