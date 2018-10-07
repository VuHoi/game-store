using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Model
{
    public class CodeFree
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public virtual Game Game { get; set; }
        public Guid GameId { get; set; }
        public CodeFree()
        {
            Id = Guid.NewGuid();
        }
    }
}
