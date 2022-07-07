import { Author } from './author.model';

export class Ranobe {

  constructor(
    public id: number,
    public name: string,
    public foreignName: string,
    public description: string,
    public chapters: number,
    public publishDate: Date,
    public status: string,
    public poster: string,
    public rating: number,
    public peopleRatedCount: number,
    public authors: string
  ) {  }

}
