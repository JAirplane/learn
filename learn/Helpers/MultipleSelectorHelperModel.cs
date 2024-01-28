namespace learn.Helpers
{
	public struct MultipleSelectorHelperModel
	{
        public string Key { get; set; }
        public string Value { get; set; }
        public MultipleSelectorHelperModel(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
