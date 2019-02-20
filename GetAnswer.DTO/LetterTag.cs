using System.Collections.Generic;

namespace GetAnswer.DTO
{
    public class LetterTag
    {
        public char Letter { get; set; }

        public List<TagDTO> Tags { get; set; }
    }
}
