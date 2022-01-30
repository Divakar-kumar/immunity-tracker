using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.IO;

public class StatusHelper
{
    private List<Status> _credentialTypes;

    public List<Status> GetStatuses()
    {
        if(_credentialTypes == null || _credentialTypes.Count == 0)
        {
            _credentialTypes = JsonSerializer.Deserialize<List<Status>>(File.ReadAllText("status.json"));
        }
        return _credentialTypes;
    }

}
public class Status
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("description")]
    public string Description { get; set; }
}