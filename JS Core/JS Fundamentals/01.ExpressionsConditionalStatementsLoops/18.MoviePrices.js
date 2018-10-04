function moviePrice(input) {
  let movie = input[0].toLowerCase();
  let day = input[1].toLowerCase();

  let result = "";

  if (movie === "The Godfather".toLowerCase()) {
    result = getPrice(day, [12, 10, 15, 12.5, 15, 25, 30]);
  } else if (movie === "Schindler's List".toLowerCase()) {
    result = getPrice(day, [8.5, 8.5, 8.5, 8.5, 8.5, 15, 15]);
  } else if (movie === "Casablanca".toLowerCase()) {
    result = getPrice(day, [8, 8, 8, 8, 8, 10, 10]);
  } else if (movie === "The Wizard of Oz".toLowerCase()) {
    result = getPrice(day, [10, 10, 10, 10, 10, 15, 15]);
  } else {
    result = "error";
  }

  function getPrice(day, prices) {
    let result = "";

    switch (day) {
      case "Monday".toLowerCase():
        result = prices[0];
        break;
      case "Tuesday".toLowerCase():
        result = prices[1];
        break;
      case "Wednesday".toLowerCase():
        result = prices[2];
        break;
      case "Thursday".toLowerCase():
        result = prices[3];
        break;
      case "Friday".toLowerCase():
        result = prices[4];
        break;
      case "Saturday".toLowerCase():
        result = prices[5];
        break;
      case "Sunday".toLowerCase():
        result = prices[6];
        break;
      default:
        result = "error";
    }

    return result;
  }
  console.log(result);
}

_________________________________________________________________;
