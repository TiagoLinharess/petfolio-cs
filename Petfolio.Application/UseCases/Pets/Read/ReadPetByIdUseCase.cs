using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.Read
{
    public class ReadPetByIdUseCase
    {
        public ResponsePetJson Execute(int id)
        {
            return new ResponsePetJson
            {
                Id = id,
                Name = "Fido",
                Birthay = new DateTime(2020, 1, 1),
                Type = Communication.Enums.PetType.Dog
            };
        }
    }
}
