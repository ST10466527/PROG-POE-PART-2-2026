using System.Collections.Generic;

namespace PROG_POE_PART_2
{
    public class MemoryManager
    {
        private Dictionary<string, string> memory = new Dictionary<string, string>();

        public void Remember(string key, string value)
        {
            memory[key] = value;
        }

        public string Recall(string key)
        {
            return memory.ContainsKey(key) ? memory[key] : null;
        }
    }
}