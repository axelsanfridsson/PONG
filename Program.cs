Console.WriteLine("Hello, World!");
Table tabl1 = new Table(30, 20);
tabl1.Render();
Ball bollen = new Ball(tabl1);

Paddle paddle = new Paddle(tabl1, 0, new int[5]);