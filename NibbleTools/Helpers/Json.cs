using Newtonsoft.Json;

namespace NibbleTools.Helpers;

public static class Json
{
    public static async Task<T> ToObjectAsync<T>(string value) =>
        await Task.Run<T>(() =>
        {
            return JsonConvert.DeserializeObject<T>(value)!;
        });

    public static async Task<string> StringifyAsync(object value) =>
        await Task.Run(() =>
        {
            return JsonConvert.SerializeObject(value);
        });
}