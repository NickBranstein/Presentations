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
            new Joke(7, 'What\'s the best thing about UDP jokes?', 'I don\'t care if you get them.'),
            new Joke(8, 'Why can\'t you trust an atom?', 'Because they make up everything.'),
            new Joke(9, 'What\'s the object-oriented way to become wealthy?', 'Inheritance.'),
            new Joke(10, 'What is a programmer\'s favorite hangout place?', 'Foo Bar.'),
            new Joke(11, 'What do you call an alligator wearing a vest?', 'An investigator.'),
            new Joke(12, 'What does a horse call the person who lives next door to him?', 'His neeeeeeeeeeeeeeeighbor!'),
            new Joke(13, 'What\'s the best thing about TCP jokes?', 'I get to keep telling them until you get them.'),
            new Joke(14, 'How many programmers does it take to screw in a light bulb?', 'None, it\'s a hardware problem.'),
            new Joke(15, 'Why do you never see elephants hiding in trees?', 'Because they\'re so good at it!'),
            new Joke(16, 'Want to hear a joke about paper?', 'Nevermind, it is terrible.'),
            new Joke(17, 'Did you hear about the guy that got hit in the head with a soda can?', 'He was lucky it was a soft drink.'),
            new Joke(18, 'Why don\'t programmers like nature?', 'It has too many bugs.'),
            new Joke(19, 'What kind of exercise do lazy people do?', 'Diddly squats.')
        ];
    }

    all(): Array<Joke>{
        return this.jokes;
    }

    random(): Joke{
        return this.jokes[Math.floor(Math.random() * this.jokes.length)];
    }
}