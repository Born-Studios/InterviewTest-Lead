# Born Studios
## Lead Developer Test

### Overview
This is the test we ask for all Lead Developer candidates to complete 
in our hiring process. We will have a follow-up discussion after you submit the test to us so 
the test itself provides the basis for us to have that discussion.

### Duration
You're free to complete the test at your own pace. It shouldn't take 
more than 2 hours of your time. If you see that it's taking longer, 
feel free to stop spending time on the implementation at that point 
and just make notes for us to go through in the follow-up interview.

### Required Tools
* Unity 2021.3.8
* C# IDE of your choice. We recommend JerBrains Rider as it will provide
you with static code analysis which will help you submit better quality code.

### Project
The provided project represents a game which connects to a server upon launch and joins a game session. Once joined, it's imagined that the server sends the player data to the app based on user credentials. The player data is assumed to contain player name (player's alias in the game), and an avatar id.

The namespaces in the codebase as follows.
  * `Network`: Contains types that are relevant to the application's connection and communication to a game session.
    * `Messages`: Contains the types that correspond to the messages exchanged between the app and the session server.
  * `Players`: Contains types that are related to the concept of "Player".
  * `Runtime`: Contains types that are about the app's runtime. `AppEntry` is a `MonoBehaviour` that instantiates the `App` singleton instance which can be used to locate dependencies.

The provided code is annotated with xml documentation. Please make sure to read 
through to gain an understanding on them.

There is only 1 scene, `App`, in the application. It's already populated with some 
objects to provide you with a starting point.

The class `SessionTester` provides the capability of simulating reception of messages from the session server. It's placed on the scene on an object with the same name and it's used through the inspector.

Player avatar prefabs are provided in the `Prefabs` folder. The avatar id that would refer to a prefab is in the prefab's name. For example `AvatarId` 1 would refer to the `PlayerAvatar-1` prefab.

### Objectives
* Construct a mechanism that will be responsible for keep the player data and provide it to the rest of the application. Note that this should not be in the view (presentation) layer, which is the scene.
* Update `UpdateData` message as a message that can update 1 or more elements of data. For example it should be possible to for the server to send this message to the app and update only player's name, only the avatar id, or both of them at the same time.
* Update `Session` class to update the local player data.
* Update `PlayerNameView` so that it will monitor the changes on player's name and update the displayed text when the name changed.
* Update `Player` class so that it will monitor the changes on player's avatar id and instantiate the avatar prefab that corresponds to the new id as a child to `AvatarRoot`.
* Monitoring the changes on data should should not be by comparing the current value with previous value in Update.

### Questions
For any questions or request for clarification, please feel free to reach us 
through the channel this test was sent to you.
