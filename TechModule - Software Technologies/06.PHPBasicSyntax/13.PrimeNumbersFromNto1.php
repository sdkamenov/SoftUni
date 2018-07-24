<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>
    <?php
    if (isset($_GET['num'])) {
        $num = intval($_GET['num']);
        for ($i = $num; $i >= 1; $i--) {
            if (is_prime($i)){
                echo $i." ";
            };
        }
    }

    function is_prime($number)
    {
        // 1 is not prime
        if ( $number == 1 ) {
            return false;
        }
        // 2 is the only even prime number
        if ( $number == 2 ) {
            return true;
        }
        // square root algorithm speeds up testing of bigger prime numbers
        $x = sqrt($number);
        $x = floor($x);
        for ( $i = 2 ; $i <= $x ; ++$i ) {
            if ( $number % $i == 0 ) {
                break;
            }
        }

        if( $x == $i-1 ) {
            return true;
        } else {
            return false;
        }
    }
    ?>
</body>
</html>