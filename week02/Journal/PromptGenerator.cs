using System;
using System.Collections.Generic;

class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What was the most challenging part of my day?",
        "What am I most grateful for today?",
        "What made me smile today?",
        "What did I learn today?",
        "How did I see the hand of the Lord in my life today?",
        "What emotion did I feel most strongly today?",
        "What is something I want to improve tomorrow?",
        "What small win did I have today?",
        "What moment today do I want to remember?",
        "What distracted me today?",
        "How did I serve someone today?",
        "What habit helped me today?",
        "What habit hurt me today?",
        "What is something I prayed about today?",
        "What thought or idea stuck with me today?",
        "How did I take care of myself today?",
        "What did I do today that required courage?",
        "What is one thing I could do better tomorrow?"
    };

    private int _lastPromptIndex = -1;
    private Random _rand = new Random();


    public string GetRandomPrompt()
    {
        if (_prompts.Count == 0)
        {
            return "";
        }

        int index;

        do
        {
            index = _rand.Next(_prompts.Count);
        }
        while (index == _lastPromptIndex && _prompts.Count > 1);

        _lastPromptIndex = index;

        return _prompts[index];
    }
}
