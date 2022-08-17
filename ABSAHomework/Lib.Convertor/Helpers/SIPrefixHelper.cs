namespace Lib.Convertor.Helpers
{
    public class SIPrefixHelper
    {
        private IDictionary<string, int> siPrefixExponents = new Dictionary<string, int>()
        {
            { "tera", 12 },
            { "giga", 9 },
            { "mega", 6 },
            { "kilo", 3 },
            { "hecto", 2 },
            { "deca", 1 },
            { "deco", -1 },
            { "centi", -2 },
            { "mili", -3 },
            { "micro", -6 },
            { "nano", -9 },
            { "pico", -12 },
        };

        /// <summary>
        /// Removes prefix prom unitName and returns its exponent
        /// </summary>
        /// <param name="unitName"></param>
        /// <returns></returns>
        public int GetUnitPrefixExponent(string unitName)
        {
            var prefix = siPrefixExponents
                .Where(prefix => unitName.StartsWith(prefix.Key))
                .Select(prefix => (KeyValuePair<string, int>?)prefix) //Making KeyValuePair nullable to check whether unitName has prefix
                .FirstOrDefault();

            return prefix.HasValue ? prefix.Value.Value : 0; // Exponent is 0 without prefix
        }

        public string GetUnitNameWithoutPrefix(string unitName)
        {
            var prefix = siPrefixExponents
                .Where(prefix => unitName.StartsWith(prefix.Key))
                .Select(prefix => (KeyValuePair<string, int>?)prefix) //Making KeyValuePair nullable to check whether unitName has prefix
                .FirstOrDefault();

            return prefix.HasValue ? unitName.Replace(prefix.Value.Key, "") : unitName;
        }
    }
}
