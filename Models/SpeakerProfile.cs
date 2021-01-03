using System.Collections.Generic;

namespace dotnet_conf_2020_demo.Models
{
    public class SpeakerProfile
    {
        public string Name { get; set; }
        public string ProfilePic { get; set; }
        public SocialLink SocialHandle { get; set; }
        public List<string> OtherInterests { get; set; }
        public string Bio { get; set; }
    }

    public class SocialLink
    {
        public string FaceBook { get; set; }
        public string Twitter { get; set; }
        public string LinkedIn { get; set; }
        public string GitHub { get; set; }
        public string Blog { get; set; }
        public string YouTube { get; set; }
    }
}