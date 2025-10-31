using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.Read
{
    public class ReadAllPetsUseCase
    {
        public ResponseAllPetJson Execute()
        {
            return new ResponseAllPetJson
            {
                Pets = new List<ResponseShortPetJson>
                {
                    new ResponseShortPetJson
                    {
                        Id = 12,
                        Name = "amora",
                        Type = Communication.Enums.PetType.Dog
                    }
                }
            };
        }
    }
}
