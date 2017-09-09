import { Component } from '@angular/core';
import { Router } from "@angular/router";
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
    showPunchline: boolean = false;
    joke: Joke;

    constructor(private jokeService: JokeService, private router: Router) {
        this.showJoke = false;
    }
  
    randomClick() {
        this.joke = this.jokeService.random();

        this.showJoke = true;
        this.showPunchline = false;
    }

    allJokesClick() {
        this.router.navigate(['list']);
    }

    showPunchlineClick() {
        this.showPunchline = true;
    }
}
