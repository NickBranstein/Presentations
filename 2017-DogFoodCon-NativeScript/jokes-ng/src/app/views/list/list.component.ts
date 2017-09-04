import { Component } from '@angular/core';
import { JokeService } from '../../services/jokeService';
import { Joke } from '../../models/joke';

@Component({
  selector: 'list',
  templateUrl: 'list.html',
  styleUrls: ['list.css'],
  providers: [JokeService]
})    
export class ListComponent {
    constructor(private jokeService: JokeService) {
    }

    allJokes(): Array<Joke> {
        return this.jokeService.all();
    }
}
