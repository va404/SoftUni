function solve(n) {
    let horizontal = n * 2 - 1
    let vertical = (n % 2 == 0) ? n - 1 : n
    let output = ''

    if (n == 2) {
        console.log("+".repeat(3));
    } else {
        for (let j = 1; j <= vertical; j++) {
              for (let k = 1; k <= horizontal; k++) {
                  if (j == 1 || j == Math.ceil(vertical / 2) || j == vertical) {
                      output += (k == 1 || k == n || k == horizontal) ? '+' : '-'
                  } else {
                    output += (k == 1 || k == n || k == horizontal) ? '|' : ' '
                  }
              }
              output += '\n'
        }
    }
    console.log(output);
}

