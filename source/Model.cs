﻿using System.Collections.Generic;
using System.Runtime.Serialization;

public class Model
{

    [DataContract]
    public class Set
    {
        [DataMember(Name = "cards")]
        public List<Card> Cards { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }
    }

    [DataContract]
    public class Card
    {
        public enum Color { Black, Blue, Colorless, Green, Red, White };

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "colorIdentity")]
        public Color color { get; set; }
    }
}
