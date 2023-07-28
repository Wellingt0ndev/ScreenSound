Episodio ep1 = new(1, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Pedro");


Episodio ep2 = new(2, "Técnicas de aprendizado", 67);
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Marcos");

Podcast podcast = new("Podcast especial", "Daniel");
podcast.AdicionarEpisodios(ep1);
podcast.AdicionarEpisodios(ep2);
podcast.ExibirDetalhes();
