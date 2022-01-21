using Newtonsoft.Json;
public class MagicItem{
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("rarity")]
    public string Rarity { get; set; }
    [JsonProperty("type")]
    public string Type { get; set; }
    [JsonProperty("attunement")]
    public bool NeedsAttunement { get; set; }
    [JsonProperty("limits")]
    public string Limits { get; set; }
    [JsonProperty("page")]
    public string Page { get; set; }

    public override string ToString()
    {
        string output = $"{this.Name} // {this.Rarity} // {this.NeedsAttunement} // {this.Page}";
        return output;
    }
}