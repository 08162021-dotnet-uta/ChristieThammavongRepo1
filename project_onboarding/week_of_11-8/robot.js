function trackRobot(N, E, S, W)
{
  let vPos = 0;
  let hPos = 0;
  if(typeof(N) !== 'undefined')
  {
    vPos += N;
  }
  if(typeof(E) !== 'undefined')
  {
    hPos += E;
  }
  if(typeof(S) !== 'undefined')
  {
    vPos -= S;
  }
  if(typeof(W) !== 'undefined')
  {
    hPos -= W;
  }
  console.log(`[${hPos}, ${vPos}]`);
}

trackRobot(20, 30, 10, 40);
trackRobot();
trackRobot(-10, 20, 10);