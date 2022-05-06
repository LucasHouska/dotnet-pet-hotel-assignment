using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace pet_hotel
{
    public enum PetBreedType
    {
        Labrador,
        Poodle,
        Shepherd,
        Beagle,
        Bulldog,
        Terrier,
        Boxer,
        Retriever

    }
    public enum PetColorType
    {
        White,
        Black,
        Golden,
        Tricolor,
        Spotted

    }
    public class Pet
    {
        public int id { get; set; }


        [Required]
        public string name { get; set; }


        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PetBreedType breed { get; set; }


        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PetColorType color { get; set; }


        public DateTime? CheckedInAt { get; set; }


        [Required]
        [ForeignKey("ownedBy")]
        public int petOwner { get; set; }

        public PetOwner ownedBy { get; set; }

    }
}
