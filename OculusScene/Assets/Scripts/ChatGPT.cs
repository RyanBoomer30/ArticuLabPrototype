using UnityEngine;
using UnityEngine.UI;
using OpenAI;
namespace OpenAI
{
    public class ChatGPT : MonoBehaviour
    {
        [SerializeField] private Text textArea;

        private OpenAIApi openai = new OpenAIApi("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");

        private string userInput;
        private string Instruction = "Pretend like you disagree with my opinion and explains why\nQ: ";

        private void Start()
        {

        }

        public async void SendReply(string question)
        {
            Debug.Log("Asking chatGPT");
            userInput = question;
            Instruction += $"{userInput}\nA: ";

            textArea.text = "...";

            // Complete the instruction
            var completionResponse = await openai.CreateCompletion(new CreateCompletionRequest()
            {
                Prompt = Instruction,
                Model = "text-davinci-003",
                MaxTokens = 300
            });

            if (completionResponse.Choices != null && completionResponse.Choices.Count > 0)
            {
                textArea.text = completionResponse.Choices[0].Text;
                Instruction += $"{completionResponse.Choices[0].Text}\nQ: ";
                Debug.Log(completionResponse.Choices[0].Text);
            }
            else
            {
                Debug.LogWarning("No text was generated from this prompt.");
            }
        }
    }
}