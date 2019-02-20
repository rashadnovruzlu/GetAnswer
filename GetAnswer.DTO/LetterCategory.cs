using System.Collections.Generic;

namespace GetAnswer.DTO
{
    public class LetterCategory
    {
        public char Letter { get; set; }

        public List<NameKeyDTO> Categories { get; set; }
    }
}
