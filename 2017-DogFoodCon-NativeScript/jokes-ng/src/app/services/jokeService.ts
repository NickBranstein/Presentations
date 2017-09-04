import { Injectable } from "@angular/core";
import { Joke } from "../models/Joke";

@Injectable()
export class JokeService{
    private jokes: Array<Joke>;
    
    constructor() {
        this.jokes = [
            new Joke(1, 'What has four wheels and flies?', 'A garbage truck.'),
            new Joke(2, 'Why can\'t dinosaurs clap?', 'Because they are dead.'),
            new Joke(3, 'Why do scuba divers fall backwards out of the boat? ', 'Because if they fell forward they\'d still be in the boat.'),
            new Joke(4, 'What\'s E.T. short for?', 'Because he\'s got little legs.'),
            new Joke(5, 'Have you ever tried eating a clock?', 'It\'s really time consuming.'),
            new Joke(6, 'Why does a chicken coop have two doors?', 'If it had four it would be a chicken sedan.'),
            new Joke(7, 'How do you fix a jack-o-lantern?', 'With a pumpkin patch.'),
            new Joke(8, 'Why can\'t you trust an atom?', 'Because they make up everything.'),
            new Joke(9, 'What\'s the object-oriented way to become wealthy?', 'Inheritance.'),
            new Joke(10, 'What is a programmer\'s favorite hangout place?', 'Foo Bar.')
        ];
        
    }

    all(): Array<Joke>{
        return this.jokes;
    }

    random(): Joke{
        return this.jokes[Math.floor(Math.random() * this.jokes.length)];
    }
}