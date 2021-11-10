let products = [
  { "name": "Mango", "cost": 40 },
  { "name": "PS5", "cost": 500 },
  { "name": "Cookie", "cost": 20 },
  { "name": "Boba", "cost": 40 },
  { "name": "Strawberry", "cost": 60 }
]

function vendingMachine(products, money, pNumber)
{
  let output = { "product": "", "change": [] }
  if(pNumber < 0 || pNumber > products.length-1)
  {
    console.log("Enter a valid product number");
  }
  else if(money < products[pNumber].cost)
  {
    console.log("Not enough money for this product");
  }
  else {
    output.product = products[pNumber].name;
    let changeAmt = money - products[pNumber].cost;
    for(let i = 0; i < 6; i++)
    {
      if(changeAmt >= change[i])
      {
        changeAmt -= change[i];
        output.change.push(change[i]);
        i--;
      }
      else
      {
        continue;
      }
    }
    console.log(output)
  }
}

let change = [500, 200, 100, 50, 20, 10];

vendingMachine(products, 200, 7);
vendingMachine(products, 500, 0);
vendingMachine(products, 90, 1);
vendingMachine(products, 20, 2);