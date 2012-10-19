namespace WineCellerService
{
    using System.Runtime.Serialization;

    [DataContract(Namespace = "")]
    public class Wine
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "grapes")]
        public int Grapes { get; set; }

        [DataMember(Name = "country")]
        public string Country { get; set; }

        [DataMember(Name = "region")]
        public int Region { get; set; }

        [DataMember(Name = "year")]
        public string Year { get; set; }

        [DataMember(Name = "picture")]
        public string Picture { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }
    }
}
