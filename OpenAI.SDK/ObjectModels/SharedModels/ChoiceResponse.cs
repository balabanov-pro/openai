﻿using System.Text.Json.Serialization;

namespace Betalgo.Ranul.OpenAI.ObjectModels.SharedModels;

public record ChoiceResponse : IOpenAIModels.ILogProbsResponse
{
    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("index")]
    public int? Index { get; set; }

    [JsonPropertyName("finish_reason")]
    public string FinishReason { get; set; }

    [JsonPropertyName("logprobs")]
    public LogProbsResponse LogProbs { get; set; }
}