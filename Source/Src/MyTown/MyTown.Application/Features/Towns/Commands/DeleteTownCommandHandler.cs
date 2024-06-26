﻿using MyTown.SharedModels.Features.Towns.Commands;
using SharedResponse;

namespace MyTown.Application.Features.Towns.Commands
    {
    public class DeleteTownCommandHandler(ITownRepository townCardTypeMasteDataRepository, IUnitOfWork unitOfWork, ITranslator translator) : IRequestHandler<DeleteTownCommand, BaseResult>
        {
        public async Task<BaseResult> Handle(DeleteTownCommand request, CancellationToken cancellationToken)
            {
            var data = await townCardTypeMasteDataRepository.GetByIdIntAsync(request.Id);

            if (data is null)
                {
                return new BaseResult(new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.ProductMessages.Product_notfound_with_id(request.Id)), nameof(request.Id)));
                }

            townCardTypeMasteDataRepository.Delete(data);
            await unitOfWork.SaveChangesAsync();

            return new BaseResult();
            }
        }
    }
