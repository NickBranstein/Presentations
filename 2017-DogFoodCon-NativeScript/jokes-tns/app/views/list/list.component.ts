import { Component } from '@angular/core';
import { JokeService } from '../../services/jokeService';
import { Joke } from '../../models/joke';

@Component({
  selector: 'list',
  templateUrl: 'views/list/list.html',
  styleUrls: ['views/list/list.css'],
  providers: [JokeService]
})    
export class ListComponent {
    constructor(private jokeService: JokeService) {
    }

    allJokes(): Array<Joke> {
        return this.jokeService.all();
    }
}
