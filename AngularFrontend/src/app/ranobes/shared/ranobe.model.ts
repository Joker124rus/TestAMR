import { Author } from './author.model';

export interface Ranobe {
  
  id: number;
  englishName: string;
  foreignName: string;
  description: string;
  chapters: number;
  publishDate: Date;
  status: string;
  poster: string;
  rating: number;
  peopleRatedCount: number;
  authors: string;

}
