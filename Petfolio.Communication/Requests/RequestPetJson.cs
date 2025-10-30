﻿using Petfolio.Communication.Enums;

namespace Petfolio.Communication.Requests
{
    public class RequestPetJson
    {
        public string Name { get; set; } = string.Empty;
        public DateTime Birthay { get; set; }
        public PetType Type { get; set; }
    }
}
