# Final Project

## What I Planned On
- Complete last Universe (Ink)
- Add finishing touches such as instructions and intro screen



## What I Accomplished
- Completed last Universe (Ink)
- Added finishing touches
- Added intro and outro screen
- Added tests


## Explanations for not including flyweight and factory
- Flyweight is a design pattern that is used to save space in memory if there is a large amount of repeated objects that have similar elements that can be reused.  The design pattern saves space by defining a flyweight object that is reused instead of creating an entirely new object each time, which reduces the amount the amount of memory used.  In my original document I chose the token class to use the flightweight pattern but ultimately noticed that it would not work for the given situation. A “token” in my game is an object at the end of 2 of the 3 levels (Universes). This object is touched by the player and a button shows up for the user to click to go back home.  This design pattern was not suited for my game because I saw no need for a token class due to the very small amount of code required for the object.  Also there were only 2 tokens and each of them were in completely different scenes and did not share any data.  The only action associated with the token is calling a go home function in the UI class on collision with the player. In Unity, if you have a large number of objects, those objects need to exist as separate entities in the game because 3D models need to physically exist for the player to interact with them.
- The factory design pattern is a method for creating objects without having to explicitly state the class of the object that will be created.  This design pattern is a method that depending on the input creates a specific object, and makes it easier to create, implement and reuse objects.  This design pattern is best suited for a program that needs to create a variety of objects.  In my original document I chose the power class to include a factory method and realized that this pattern could not be used in the context of my game.  Within unity, 3D objects are placed in the editor and then code is attached to the 3D object.  Thus making the factory method not usable because you already have created the 3D object and then code is attached to it.  The design pattern is not usable because the 3D object was created in Maya and then exported to Unity. I cannot call a factory method to create a 3D object that was created in another application.

## What I Would do Next
- I would completley change the home land because I do not like the way it looks
- Make each level longer and more complex




## Screenshots
![Pic1](/ImagesAndVideos/introScene.gif)
![Pic2](/ImagesAndVideos/inkUni.gif)
![Pic3](/ImagesAndVideos/paintUni.gif)
![Pic4](/ImagesAndVideos/waterColUni.gif)
