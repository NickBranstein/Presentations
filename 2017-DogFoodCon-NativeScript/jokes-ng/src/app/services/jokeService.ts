import { Injectable } from "@angular/core";
import { Joke } from "../models/Joke";

@Injectable()
export class JokeService{
    private jokes: Array<Joke>;
    
    constructor() {
        this.jokes = [
            new Joke(1, 'joke1', 'punchline 1'),
            new Joke(2, 'joke2', 'punchline 2'),
            new Joke(3, 'joke3', 'punchline 3'),
            new Joke(4, 'joke4', 'punchline 4'),
            new Joke(5, 'joke5', 'punchline 5'),
            new Joke(6, 'joke6', 'punchline 6'),
            new Joke(7, 'joke7', 'punchline 7'),
            new Joke(8, 'joke8', 'punchline 8'),
            new Joke(9, 'joke9', 'punchline 9'),
            new Joke(10, 'joke10', 'punchline 10'),
            new Joke(11, 'joke11', 'punchline 11')
        ];
        
    }

    all(): Array<Joke>{
        return this.jokes;
    }

    random(): Joke{

        return this.jokes[Math.floor(Math.random() * this.jokes.length)];
    }
}