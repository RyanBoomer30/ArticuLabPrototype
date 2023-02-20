# VRDebate
Winner at Stanford's TreeHack2023 on best frontier

## Inspiration
Public speaking is an incredibly important skill that many seek but few master. This is in part due to the high level of individualized attention and feedback needed to improve when practicing. Therefore, we want to solve this with AI! We have created a VR application that allows you to get constructive feedback as you present, debate, or perform by analyzing your arguments and speaking patterns. While this was our starting motivation for ArticuLab, we quickly noticed the expansive applications and social impact opportunities for it. ArticuLab could be used by people suffering from social anxiety to help improve their confidence in speaking in front of crowds and responding to contrasting opinions. It could also be used by people trying to become more fluent in a language, since it corrects pronunciation and word choice.

## What it does
ArticuLab uses AI in a VR environment to recommend changes to your pace, argument structure, clarity, and boy language when speaking. It holds the key to individualized public speaking practice. In ArticuLab you also have the opportunity to debate directly against AI, who'll point out all the flaws in your arguments and make counterarguments so you can make your defense rock-solid.

## How we built it
For our prototype, we used Meta's Wit.AI natural language processing software for speech recognition, built a VR environment on Unity, and used OpenAI's powerful ChatGPT to base our feedback system on argument construction and presenting ability. Embedding this into an integrated VR App results in a seamless, consumer-ready experience.

## Challenges we ran into
The biggest challenge we ran into is using the VR headset microphone as input for the speech recognition software, and then directly inputting that to our AI system. What made this so difficult was adapting the formatting from each API onto the next. Within the same thread, we ran into an issue where the microphone input would only last for a few seconds, limiting the dialogue between the user and the AI in a debate. These issues were also difficult to test because of the loud environment we were working in. Additionally, we had to create a VR environment from scratch, since there were no free assets to fit our needs.

## Accomplishments that we're proud of
We're especially proud of accomplishing such an ambitious project with a team that is majority beginners! Treehacks is three of our integrants' first hackathon, so everyone had to step up and do more work or learn more new skills to implement in our project.

## What we learned
We learned a lot about speech to text software, designing an environment and programming in Unity, adapting the powerful ChatGPT to our needs, and integrating a full-stack VR application.

## What's next for ArticuLab
Naturally, there would be lots more polishing of the cosmetics and user interface of the program, which are currently restricted by financial resources and the time available. Among these, would be making the environment a higher definition with better quality assets, crowd responses, ChatGPT responses with ChatGPT plus, etc. ArticuLab could be useful both academically and professionally in a variety of fields, education, project pitches like Treehacks, company meetings, event organizers… the list goes on! We would also seek to expand the project to alternate versions adapted for the comfort of the users, for example, a simplified iOS version could be used by public speakers to keep notes on their speech and let them know if they're speaking too fast, too slow, or articulating correctly live! Similarly, such a feature would be integrated into the VR version, so a presenter could have notes on their podium and media to present behind them (powerpoint, video, etc.), simulating an even more realistic presenting experience. Another idea is adding a multiplayer version that would exponentially expand the uses for ArticuLab. Our program could allow debate teams to practice live in front of a mix of AI and real crowds, similarly, ArticuLab could host online live debates between public figures and politicians in the VR environment.
