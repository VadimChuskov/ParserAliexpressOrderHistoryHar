using Newtonsoft.Json.Linq;
using ParserAliexpressOrderHistoryHar.Classes;

const string harFilePath = @"c:\Hobby\ParserAliexpressOrderHistoryHar\www.aliexpress_full.com.har";

var logger = new ConsoleLogger();

if (!File.Exists(harFilePath))
{
    logger.Error($"File {harFilePath} not found!");
    return;
}

logger.Log($"File {harFilePath} found!");
logger.Log("Start reading the file...");

var fileContent = File.ReadAllText(harFilePath);

logger.Log("End reading the file");

logger.Log("Start parsing...");

var root = JObject.Parse(fileContent);

//var entries = root.SelectTokens("log.entries[*]").ToList();
var resourceTypes = root.SelectTokens("log.entries[*]._resourceType")
    .Distinct()
    .ToList();

logger.GreenRaw(String.Format("|{0,12}|", "Found types"));
logger.GreenRaw("--------------");
foreach (var resourceType in resourceTypes)
{
    logger.GreenRaw(String.Format("|{0,12}|", resourceType));
}

logger.Log("Will be parsed: \"xhr\" and \"image\"");

var xhrEntries = root.SelectTokens("log.entries[?(@._resourceType == 'xhr')]").ToList();
var imageEntries = root.SelectTokens("log.entries[?(@._resourceType == 'image')]").ToList();

logger.Log($"xhr items found - {xhrEntries.Count}");
logger.Log($"image items found - {imageEntries.Count}");

logger.Log("End parsing");