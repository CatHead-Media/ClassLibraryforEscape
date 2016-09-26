using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryforEscape
{
    //Anything that counts as an object 
    public class Entity
    {
        
    }

    //Super class for background objects
    public class Scene
    {

    }

    //Interactable thing?
    public class Actor : Entity
    {

    }

    //Object represented by artwork?
    public class Sprite 
    {

    }

    //Takes the place of treasure in the original game, sprite characters in the shape of cats
    public class HelperFriendCat
    {


    }

    //Objects that come into affect when a player enters the room it is in, cause an affect and have a sprite
    public class Curse
    {

    }

    //Game tiles that make up the rooms
    public class Tile
    {

    }

    //Interactable sprite supercategory of rats, player, witch, and friendcats
    public class Character
    {

    }

    // Primary antagonist, subtype of character unique atributes such as cost to kill
    public class Rats
    {

    }
    
}
