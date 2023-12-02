/* 
  Leia 2 valores inteiros e armazene-os nas variáveis A e B. Efetue a soma de A e B atribuindo o seu resultado na variável X. Imprima X conforme exemplo apresentado abaixo. Não apresente mensagem alguma além daquilo que está sendo especificado e não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".

  Entrada
  A entrada contém 2 valores inteiros.

  Saída
  Imprima a mensagem "X = " (letra X maiúscula) seguido pelo valor da variável X e pelo final de linha. Cuide para que tenha um espaço antes e depois do sinal de igualdade, conforme o exemplo abaixo.

  Exemplos de Entrada	Exemplos de Saída
  10
  9
  X = 19

  -10
  4
  X = -6

  15
  -7
  X = 8
*/

const readline = require("readline");

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout,
});

let a, b;

rl.question("Digite o valor de A: ", (answer) => {
  a = parseInt(answer);

  rl.question("Digite o valor de B: ", (answer) => {
    b = parseInt(answer);

    const X = a + b;

    console.log(`\nX = ${X}`);

    rl.close();
  });
});
