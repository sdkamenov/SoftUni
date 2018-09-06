<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>
<?php
/*
for ($row = 1; $row <= 9; $row++) {
    for ($col = 1; $col <= 5; $col++) {
        if ($row == 1 || $row == 5 || $row == 9 ||
            ($row == 2 && $col == 1) ||
            ($row == 3 && $col == 1) ||
            ($row == 4 && $col == 1) ||
            ($row == 6 && $col == 5) ||
            ($row == 7 && $col == 5) ||
            ($row == 8 && $col == 5)) {
            echo "<button style='background-color: blue'>1</button>";
        } else {
            echo "<button>0</button>";
        }
    }
    echo "<br>";
}
*/
?>

<?php
$buttons = [
    [1, 1, 1, 1, 1],
    [1, 0, 0, 0, 0],
    [1, 0, 0, 0, 0],
    [1, 0, 0, 0, 0],
    [1, 1, 1, 1, 1],
    [0, 0, 0, 0, 1],
    [0, 0, 0, 0, 1],
    [0, 0, 0, 0, 1],
    [1, 1, 1, 1, 1],
];
for ($row = 0; $row < 9; $row++) {
    for ($col = 0; $col < 5; $col++) {
        $currentElement = $buttons[$row][$col];
        if ($currentElement == 1) {
            echo "<button style='background-color: blue'>$currentElement</button>";
        } else {
            echo "<button>$currentElement</button>";
        }
    }
    echo "<br>";
}
?>
</body>
</html>