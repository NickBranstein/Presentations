import { Component } from '@angular/core';
import { JokeService } from '../../services/jokeService';
import { Joke } from '../../models/joke';

@Component({
  selector: 'home',
  templateUrl: 'home.html',
  styleUrls: ['home.css'],
  providers: [JokeService]
})    
export class HomeComponent {
    showJoke: boolean = false;
    joke: Joke;

    constructor(private jokeService: JokeService) {
        this.showJoke = false;
    }
  
    randomClick() {
        this.joke = this.jokeService.random();

        this.showJoke = true;
    }
}
