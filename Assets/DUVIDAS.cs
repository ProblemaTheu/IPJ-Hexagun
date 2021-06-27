/* 

Professor, bom dia, boa tarde ou boa noite, somos os integrantes do jogo Hex a gun, estamos muito animados e focados nessa materia e em pouco tempo conseguimos 
criar nosso gerador de mapa, criar nossas ideias, definir os personagens, a história, as habilidade e mais, porém estamos há algumas semanas empacados na 
criação e ação dos nosso personagens, visto que mexer com Inteligencia Artificial não é facil e a grande maioria dos tutoriais que vemos
esta relacionando Inteligencia Artificial e Personagem (player), então está realmente muito complicado de aplica-los no nosso jogo, gostariamos muito de 
ter essas duvidas saciadas, talvez alguns codigos especificos que podemos usar, ou até mesmo dicas de canais e videos que podemos consultar, pois essa 
construção de IA realmente esta nos complicando. (tentamos varias vezes, como pode ver, existem varios e varios Scripts na pasta "obsoletos", onde, tentamos 
aplicar um determinado codigo e não conseguimos). Por isso separamos 3 aspectos que estão sendo um problema.

I - Professor, nosso jogo tera hexagonos com diferentes marcacoes que dara aumentos ou diminuicao de forca para os que collidirem nele, porem ao usar "OnCollisionEnter"
o jogo funciona normalmente quando linkamos a colisão entre projetil e personagem, mas nao funciona quando linkamos a colisão entre terreno e personagem
(sendo que o personagem fica o tempo todo colidindo com o terreno qual se encontra), gostariamos de:

1º Saber um modo de fazer com que o personagem ao caminhar por cima do terreno proposto tenha uma atualizacao no valor de sua velocidade, ou ataque, ou vida,
etc...

II - Alem disso, nosso jogo é baseado em IA vs IA, não existe um player/controlador especifico, ou seja, precisamos de codigos que façam
com que as IA's interajam entre si, enfim, criamos codigos onde as IA do time 1, por exemplo, se movimentam até um "range" em direção ao time 2 
e fazem suas acoes, dentre elas, atirar quando chegar no range, se afastar quando tiver perto demais, ou avançar quando tiver longe demais, porem
eh um sistema simples usando apenas "CompareTag" e "Transform.position" e sabemos que existe uma engine.AI para criar e modelar Inteligencia Artificial 
de modo mais complexo e mais util, minha duvida é a seguinte, como posso encaixar essa Engine no meu jogo, para definir os seguintes parametros:

1º Time1 precisa encontrar o alvo mais proximo do Time2 e foca-lo como seu alvo (é necessario que esse alvo seja definido pela tag, pois sera 5x5 e cada 
time tera uma tag pros seus respectivos combatentes)

2º Time1 precisa ter uma capacidade de se movimentar durante o combate (talvez desviar de tiros inimigos, caminhar para um terreno proximo e mais propenso ou 
simplesmente não deixar que o jogo sera parado e monotono)

3º Uma acao muito especifica, gostariamos que o personagem "Melee" ao atacar um inimigo sofra um KnockBack e fique um tempo atordoado até poder atacar 
novamente pois nosso personagens de ataque corpo a corpo simplesmente encostam no inimigo e os empurram ate a borda do jogo.

III - Por ultimo e não menos importante, como os personagens são diferentes, eles vão possuir valores de vida e energia diferentes, gostariamos de:

1º Criar uma barra de vida e energia individual que sejam convertidas em uma barra de vida em grupo, que ao chegar em 0, defina o vencedor da partida

2º Criar um código de habilidade, onde, ao ter a barra de energia completa, o personagem pare todas suas ações (movimento, ataque, fuga) para usar sua 
habilidade (minha duvida maior é: onde devo colocar esse codigo ? no update();, antes ou depois das ações de ataque e movimento ? ou deveria ser um 
private void separado que seja "chamado" dentro do update();)

Agradeço desde já qualquer ajuda possivel para nos tirar desse buraco e peço desculpas pelo amontoado de duvidas que estamos tendo, mas realmente estamos
animados com o jogo e gostariamos de entregar o melhor trabalho possivel

Att. Hex a Gun

 
 
 
 
 
 
 
 
*/