﻿using Jantuscara.Application.Common;

namespace Jantuscara.Application.Interfaces.UseCases.Recipe
{
    public interface IDeleteRecipeUseCase
    {
        Task<IMessageResponse> ExecuteAsync(Guid id);
    }
}
