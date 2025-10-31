﻿using Petfolio.Communication.Enums;

namespace Petfolio.Communication.Responses
{
    public class ResponsePetJson
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Birthay { get; set; }
        public PetType Type { get; set; }
    }
}
