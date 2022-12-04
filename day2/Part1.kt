import kotlin.Pair.*

fun main() {
    val rounds = inputString.split("\n")
    val roundMoves = rounds.map { it.split(' ') }.map { it.first() to it.last() }
    val roundScores = roundMoves.map { (opponentMove, myMove) -> moveScore(myMove) + resultScore(opponentMove, myMove) }
    println(roundScores.sum())
}

fun moveScore(move: String) = when(move) {
    "X" -> 1
    "Y" -> 2
    "Z" -> 3
    else -> throw RuntimeException()
}

fun resultScore(opponentMove: String, myMove: String) = when(opponentMove) {
    "A" -> when(myMove) {
        "X" -> 3
        "Y" -> 6
        "Z" -> 0
        else -> throw RuntimeException()
    }
    "B" -> when(myMove) {
        "X" -> 0
        "Y" -> 3
        "Z" -> 6
        else -> throw RuntimeException()
    }
    "C" -> when(myMove) {
        "X" -> 6
        "Y" -> 0
        "Z" -> 3
        else -> throw RuntimeException()
    }
    else -> throw RuntimeException()
}

val inputString = """B X
B Z
B Z
A Y
B X
A Y
C Y
A Y
C X
B X
A Y
B Z
A Y
A X
B X
A Y
A Y
B Y
A Y
A Y
A Y
B Y
C Y
A Y
A Y
C X
B Z
B Z
C Z
B Z
A Y
A Y
B Z
A Y
B X
A Y
A Y
A Y
C Z
A Y
C Y
B X
A Y
A Y
A Y
B X
A X
B Y
B Z
A Y
A Y
A Y
B Z
A Y
A Y
B Y
B X
C Y
B Z
C Z
A Y
C X
B Z
A Z
C X
A Y
A Y
A Z
B Z
A Y
A Y
B Y
B Z
A Y
A Y
C X
B X
A Y
B Z
A Y
B Y
B Y
A Y
B Y
B Z
B X
B Y
B X
B Z
B Z
A Y
A Y
A Z
A X
A Y
B Z
A Y
B X
A X
A Y
B X
A X
A Z
B Z
A Y
A Y
A Y
B Z
A Y
B X
A Y
A Y
B Z
B Y
A X
C Y
C Y
A Y
B X
B X
B Z
B Z
B Y
B Y
B Z
B Z
B X
B Z
B Z
B Z
A Y
A Y
B Z
B Z
B X
A Y
C Z
B Z
B X
B Z
A X
A Y
B X
B X
A Y
B X
B Z
B Z
A Z
B Y
A Y
B X
A Y
C Y
B Y
A Y
A Y
B Y
B X
A Y
B X
B Z
A Y
B Z
B X
B X
A Y
A Y
B Z
A Z
B Z
C Z
B Z
C X
A Y
A Y
A Y
A Y
A Y
A Z
B Z
B Y
C Y
A X
C Y
A Y
A X
B Z
A Y
C Z
A Y
A Y
A Z
C Y
C Y
A Y
A Y
A Y
B Z
B Z
B X
B X
B Y
A Y
A X
B Z
B X
B Z
A Y
B Z
A X
B Z
A Y
A Y
B Z
A X
B Y
A Y
A Y
A Y
B X
A Y
C Z
B Y
B X
A Y
B Z
A Y
A Y
A Y
B Z
A Z
C Y
A Y
A Y
B Z
A Y
A Y
A Y
B Z
A Z
A Y
A Y
A Y
A Y
A Y
A Y
B X
A Y
B X
A Y
C Z
B Z
A Y
A Y
B Z
A Y
A Y
B Z
A Y
A Y
A Y
B Z
A Z
A Y
A Y
C Y
A Y
A Y
A Y
B Z
A Y
A Z
B Z
C Y
B Y
B Z
B Z
C X
A Y
A X
B Y
A Y
B Z
A X
B Y
C Y
B Z
A Y
A Y
B X
A Y
B Z
B Z
B X
B Z
A Y
A Y
A Y
A Y
A Y
A Y
B Y
A Y
A Y
A Y
A Y
A Y
B Z
A Y
A Y
A Y
A Y
A Y
B Y
B Y
A Y
A Z
A Y
A Y
A Y
B X
B Z
A X
A Z
A Y
B X
A Z
A Y
B X
A X
B X
A Y
A Y
B X
B X
A Y
B X
A Y
A Y
B Y
B Z
A Y
A Y
B Z
C X
B X
B Z
B Z
A Y
A X
A Y
A Y
C Y
A Y
B Z
C Y
C Y
A Y
A Y
B X
A Y
A Y
A Y
A Y
A X
A Y
B Y
B Z
A Y
B Z
B X
C Y
B Z
B X
B Z
A Y
A Y
A Z
A Y
C Y
B Z
A Y
A Y
B Y
B Z
B Z
A X
A Y
B Z
A Y
B X
A Y
A Y
B Z
B X
B Z
A Y
A Y
B Y
B Z
B X
A Y
B X
A Y
A Y
A Y
A Y
A Y
B Z
A Y
B Y
A Z
B X
B Z
B X
A Y
B X
A Y
B Y
B Y
A Y
C Z
C Y
A Y
B Z
B X
A Y
A Y
A Y
A Y
B Y
B Z
B Z
A Y
A Y
A Y
A Y
B X
A Y
B Y
B Z
A Y
B Z
B Z
B Z
A Y
B Z
B Z
B X
B Z
A Y
B Z
A Y
B X
B Z
A Y
A Y
A Y
C Y
B Z
C Z
A Y
B Z
C Y
A Y
A Y
A Y
B Z
A Y
A Y
B X
B X
A X
A Y
A Y
B X
B X
A X
A Y
A Y
A X
B X
B Y
A Y
A Y
B X
B Z
B X
A Y
B X
B Y
A Y
B Y
B X
A Z
A Y
A Y
B X
A X
A Z
B X
A Y
A X
B X
A Y
A Y
A Y
A Y
A Y
B Y
A Y
B X
B Y
B Z
B Y
A Y
A Y
A Y
A Y
B Y
A Y
A X
B Y
A Y
B Z
A Y
A Z
A Y
A Y
A Y
C Z
A Y
A Y
B X
B X
C Z
A Y
B Z
A X
B X
A Y
B Z
A Y
B Z
A Y
A Y
B Z
A X
A X
B X
B Y
B Z
B Z
C Z
A Y
A X
A Y
C X
A Y
B X
B X
B Z
A Y
A Z
A Y
C Z
B Z
B Y
B Z
C Y
C X
A Y
B X
B Z
A Y
B X
B Y
A Y
A Y
A Y
A Y
B Z
C Y
B Y
C X
A Y
A Y
B Z
C Y
B Z
A Y
A X
A Y
A Y
A Y
A Y
B X
C Y
A Y
A Y
B X
A Y
B X
B Y
C Z
A Y
A Y
A Y
A Y
B Z
B X
C Y
B X
A Y
A Z
C Y
A X
A Y
B Z
B Z
A Y
A Y
C Y
A Y
B X
C Z
B Z
A X
A Y
A Y
B Z
B Z
A Y
B X
B X
B X
A Y
B X
B Z
A Y
A Y
A Y
A Y
C Y
A Y
C Z
A X
B Z
B X
A Y
B X
A Y
B Y
A Y
A Z
A Y
A Y
B Z
B Y
B X
B Z
A Y
A Y
A Y
A Y
A Y
A Y
A Y
A Y
C Z
B Z
B X
A Y
A Z
B Y
A Y
A Y
B Y
A Y
B Y
B X
A Y
A Z
A Y
A Y
A Y
A Y
A Z
A Y
B Z
A Y
A Y
B Z
B Z
A Y
C Z
B X
A Y
C Y
B X
A Y
B X
B Z
B Z
A Y
A Y
A Y
A X
B X
B X
A Y
B Y
B Y
A Y
A X
A Y
B Z
C Y
A Y
C Z
B Z
C Y
B X
A Z
A Y
A Y
A Y
A Y
C X
B X
B X
A Z
B Y
A Y
A Y
B X
A Y
A Y
A X
B X
C Z
B X
C Y
A X
B X
C Y
C X
A Y
A Y
B Y
C Y
A Y
B X
B Z
A X
A Y
B X
B Z
B Z
B X
B Z
B Y
A Y
A Y
A Y
A Y
A Y
A Z
B Y
A X
B X
C Y
A Y
B Y
A Y
B X
A Y
A Y
A Y
A Y
A Y
A Y
B Z
B Z
A Y
A Y
A Y
C Z
A Y
A Y
A Z
B Z
C Y
B Z
A Y
B Z
A X
A Y
B X
B Z
A Y
A Y
A Y
A Y
B X
B Y
C Z
A Y
A Y
A Y
C Z
A X
B Z
B X
C Y
B X
B X
A Y
C Y
B X
A Z
A Y
B X
A Y
A Y
B Z
A Y
A Y
A Y
B Y
A Y
A Y
A Y
A Y
B X
C Y
A Y
A Y
A Y
A Y
A Y
B Z
B X
B Z
A Y
B X
A Y
B X
C Y
A Y
A Y
A Y
C Y
A Z
A Y
A Y
B Y
B Z
B Z
A Y
B X
A Y
B X
C Y
A Y
B X
B X
B X
A Y
B Y
A Y
A Y
B X
B X
A Y
A Y
C Y
A Y
B Z
A Y
A Y
B Z
A Y
C Y
B X
A Y
A Y
A Y
B X
B X
B X
A Y
B Z
B Z
B X
B Z
A Y
B X
B Z
A Y
A Y
C Z
B X
B X
C Z
C Y
A Y
C Z
A Y
A X
B Z
A Y
A Y
A Y
B Z
B Z
B Z
A Y
A Y
B Z
C Y
A Y
A X
B Z
A Y
A Y
B Z
B Z
C Y
C Z
A Y
A X
B Z
C Z
B Y
B X
B X
B X
B Y
B X
A Y
B X
B Z
B Z
A Y
B Z
A Y
A Y
A Y
B X
A Y
A Y
B X
A Y
A Y
A Y
A Y
A Z
B X
A Y
B Z
A Y
A Y
B Z
A Y
A Y
A Y
A X
A Z
A Y
B Y
C Y
A Y
A Y
A Y
C Y
A Y
B X
A Y
B Z
B X
B Z
A Y
B Z
A Z
B X
A Y
A Z
B X
B X
B Z
A Y
A Y
B Z
A Z
A Y
C Y
A Y
A Y
B Z
B Z
B X
C Y
B X
A Y
B X
B Y
B Y
C Z
A Y
A Y
B Z
B X
A Y
A X
A Y
A Z
A Y
B Y
A X
A Y
B Y
A Y
B X
A Y
A Y
A Y
A Y
B Z
A Y
A Y
A Y
B X
A Y
B Y
A Y
A Y
B X
B Y
B X
B Z
A X
A Y
B X
B Z
A Y
B Y
B Y
A X
C Y
B Z
B X
A Y
B Z
A X
B Y
B X
A Y
C Y
B Z
B X
A Y
B Z
C Z
A Y
A Y
A Y
A Y
B X
B X
A X
A Y
A Y
A Y
A X
C Y
C X
B Z
A Y
A Y
B X
A Y
A Y
C Y
B X
A X
B X
C X
A Z
A Y
C Z
A Y
A Y
B Z
B Z
C Y
A Y
A Y
B X
B X
A Y
C X
A X
A Y
A Y
A Y
B Y
A Y
A Y
B X
A Y
B Z
C X
A Y
B X
A Y
A X
A Y
A X
B X
A Y
A Y
A Y
B Y
B Z
B Z
B X
B Z
A Y
B Z
A Y
B Z
C Z
A Z
A Z
B X
A X
B Z
B Z
A X
B X
C X
C X
A X
A Y
A X
B Z
C Y
B X
B Z
B X
A Y
A Y
A Y
B X
B Z
B Z
B Z
A Y
A Y
B Y
B Z
A Y
A Y
C Y
A Y
A X
A Y
A Y
A Y
B Z
B Z
A Y
B X
A Y
A Y
A Y
A Y
A X
A Y
B Z
A Y
A Y
B Z
A Y
A Y
A Y
B X
A Y
C Y
B X
A Y
A X
A Y
B Z
B Z
B Z
B Z
B Z
A Z
B Z
A Z
C Y
B X
B Y
A X
B X
B X
A Y
A Y
A Y
A Y
B Y
A Y
A Y
A X
A Y
B Y
B X
C Y
B X
C X
A Y
B Z
A Y
A Y
B Z
A Y
A Y
B X
A Y
C Y
A Y
A Y
A Y
C Z
A X
B Y
A Y
C Y
A Y
B Z
A Y
B Z
B X
A Y
A Y
C Y
A Y
B Y
B Z
A Y
B X
A Y
A Y
C Y
C X
A Y
B Z
A Y
B X
B Z
B X
B X
A Y
A Z
B X
A Z
A Y
C Y
B Y
B X
A Y
A Y
A Y
B X
B Z
B Y
B X
A Y
A Y
A Y
A Y
A X
A Y
B X
A Y
B Z
B Z
B X
A Y
A Y
C X
B Z
B Z
B Y
A Z
B Y
B Y
C Z
A X
B X
B X
A Y
A Y
B X
A Y
B Z
B X
B X
C X
B Z
A Y
A Y
B X
B Z
A Y
B Y
A Y
B X
B X
B X
B Y
A Y
B Z
A Y
B Y
B Z
B X
B X
A Y
A Y
A Y
C Y
B X
B Z
A Z
A Y
A Z
A Y
A Y
B Z
A Y
B Z
C Z
B X
A Y
B Z
A Y
A X
B Y
A X
C Y
B Z
B Z
A Y
A X
B Z
C Z
B Z
A Y
A Y
A Y
A Y
A Y
B Z
A Y
A Y
B Z
A Y
A Y
A Y
A Y
B X
B Z
A Y
A Y
C Y
B Z
A Y
C Y
C Z
B Z
A Y
A Y
C Z
B Z
B Y
B X
A Y
A Y
B Z
A Y
C X
B Z
B X
B Z
B X
B Z
B Z
B Z
A Y
A Y
A Y
C Y
A Y
A Y
B Z
B X
B X
A Y
A Y
A X
A Y
A Y
A X
B X
B Y
B Z
A Y
A X
C Z
A Y
C Y
B X
A X
B Z
A Y
B Z
B Z
B X
A Y
A Y
C Z
A Y
A X
A Y
A Y
C Z
A Y
B X
A Z
B Z
B X
A Y
A X
A Y
A Z
B X
B Z
A Y
B Y
A Y
A Y
A Y
A Y
A Y
A Y
B X
C Y
A X
B Z
B X
B X
A Y
A Y
B X
A Y
C Y
A Y
A Y
B X
A Y
C X
A Y
B Z
B X
A Y
A X
C X
A Y
A Y
B Y
A Y
B Z
C Z
B X
B Y
C X
A Y
B X
A Y
B X
B Z
B Y
A Y
A Y
A Y
A Y
A Y
A Y
A Y
B X
A Y
A Y
B Z
B Z
A Y
C Y
B X
A Y
A Y
A Y
B X
A Y
B Z
A Y
B X
B Y
B X
B Y
B X
B Z
A X
B Z
C Z
B Y
A Y
A X
A Z
B Z
B Z
B Z
A Y
A Y
A Y
A Y
A Y
B Z
A Y
A Y
B Y
A Y
A Y
C Z
B Y
C Y
A Y
B Z
A Y
B Z
A Y
B X
A Z
B Z
A Y
A Y
A Y
A Y
A Y
A Y
A Y
A Y
A Y
B Z
B X
A Y
B Z
A Y
A Z
A Y
B Y
A Y
B X
B X
B Z
A Y
A Y
A Y
B Z
B Y
A Y
B X
C Z
A X
B Z
B X
A Y
A Y
A Z
B X
A X
A Y
C Y
C Y
A Y
A Y
A Y
A Y
B Z
B X
B X
A Y
B X
A Y
B X
A Y
A X
B X
B Z
A Y
B X
B X
B Z
B Y
A Y
B Z
A Y
A Y
A Y
A Y
B Y
B Y
B X
B Y
B X
B X
A Y
C X
A X
B X
A Y
B Z
A Y
A Y
B Z
B X
A Y
B Z
B X
B Z
A Y
A Y
A Y
A Y
B Y
B Z
A X
B Z
B X
A Y
A Y
C Z
A Y
B X
B Z
A Y
A Y
C X
A Y
C Y
A Z
A Y
B Y
B X
A Y
B Z
A Y
A Y
A Y
A Y
A X
B Z
B X
B Z
A Y
A Y
B X
A Y
C Z
B X
B X
A Y
A Y
B X
B Y
A Y
A Y
A Y
B Z
A X
A Y
A Y
A Y
A Y
B X
B Z
C Y
B Z
B X
A Y
B Z
A Y
B Z
A Y
C X
A Y
A Y
C Y
A Y
A Y
A Y
A Y
A Y
B X
B Y
A X
A Y
B Z
C Y
A Y
A Y
B X
A X
A X
B X
A Y
A Y
A Y
A X
C Y
B X
A Y
A Y
A Y
A Y
A Y
A Y
B Z
A Y
B Z
C Y
A Y
A Y
A Y
A Y
B Z
B Z
A X
A Y
A X
A X
A Y
A Y
B Z
B X
A Y
A Y
B X
B Y
C Z
A X
A X
A Y
B X
A Y
B X
B Z
A Y
B X
A Y
A Y
B Z
B X
B X
B X
A Y
A Y
B Z
B Z
A Y
B Y
A Y
A Y
A Y
A Y
B X
A X
B Y
B X
A Y
C X
B Z
B X
A Y
B X
B X
B X
B Y
B Y
A Y
A Z
B Z
C Y
A Y
A Y
A Z
A X
A Y
C Y
A Y
B Z
A Y
C Y
C Y
B Z
A Y
B Z
B Z
A Y
B Z
A Y
C Y
B Z
B X
B X
A Y
A Y
C Y
A Y
A Y
A Y
A X
A Y
A Y
A Y
C Z
B X
B Y
B X
A Y
A Y
C Y
A Y
A Y
A Y
B Z
B Y
A X
B Z
A Y
A Y
C Y
A Y
A Y
C Y
B X
B X
A Y
C Z
A Y
A Y
A Y
C Y
B Y
B Z
B Y
C X
A Y
B Y
C Y
B Z
A Y
B X
B X
A Y
A Y
A Y
B Y
B Y
A Y
A Y
B X
A Y
B Y
A Y
A Y
B Z
B Z
A Z
B X
B Z
B X
A Y
A Y
B Z
B Z
C Y
A Y
B Z
B Y
A Y
B X
B Z
B Z
A X
B X
A Y
A Z
B Z
A Y
B X
A Y
A Y
A Y
B X
B X
B Z
A Y
A Y
A X
C X
A Y
A X
B Z
B Z
A Y
C Y
B Z
B Z
B Y
B Z
A X
A Y
A Y
B Z
B X
A Y
C Z
A X
A Y
B Z
B X
C Y
A Y
A Y
B Y
B X
A Z
B X
A Y
A Y
B Z
C Z
B Z
B Z
A Y
A Y
A Y
B X
A Y
A X
C X
A Y
A Y
B Z
A Y
B Y
B X
A Z
A Y
A Y
A Y
C Y
B X
B Y
A Y
B Y
C Z
B X
B Z
B Z
B X
A Y
B Z
B X
A Y
A X
B Y
A Y
A Z
B X
B Z
A Y
C Z
B X
B Z
A Y
A X
A Y
B Z
B Z
A X
C Y
B X
C Z
B Y
A X
B X
C Y
A Y
B Y
B Z
A Y
A Y
A Y
A Y
B Y
B Z
B X
B X
A Y
A Z
B X
A Y
A Y
A Y
A X
B Z
C Z
C Y
B X
A Y
A Y
A Y
C X
B Z
B Z
A Y
A X
B X
A Y
B X
A X
B X
B Z
B X
B X
A Y
A Y
B X
A Y
A Y
A Y
B Z
B Y
B Z
A Y
A Y
A Y
B Z
A Y
A Y
A Y
C Y
B Y
B Z
A Y
B X
B Z
B Y
B X
A Y
A Y
A Y
A Y
C Z
A Y
A X
A Y
A Y
A Y
A Y
B Z
B Z
B Z
C Y
A Y
A Y
A Y
A Z
A Y
C Y
A Y
A Y
B Z
A Y
A Y
A Y
B X
A Y
B Y
A Y
A Y
B Z
B X
A Y
A Y
B Y
B X
A Y
B X
A Y
A Y
A Y
A Z
A Y
B X
B Y
B X
C Y
B Z
A X
A Y
A Y
A Y
B Z
B X
B X
B Z
B Y
A Y
A Z
A Y
C Z
B X
A Y
B Z
B Z
B Y
B X
A Y
C X
A Y
A Y
A Y
A Y
B Z
B Z
A Y
A Y
A Y
B Z
A Y
A Y
A Y
A Y
A Y
A Y
A Y
B X
A Y
C Y
B Z
B Z
A Y
A Y
A Y
B Y
A X
B Z
A X
B Z
B Y
A Y
B Z
B X
B X
A Y
A Y
A Y
B Z
A Y
A Y
B X
B X
A Y
B X
A Y
B X
A Y
B Z
A Y
B X
A Z
B Z
A Y
C Y
A Y
A Y
C Y
A Y
A Y
A X
A Y
C Y
A Y
A Y
B X
A Y
A Y
B X
C Y
A Y
B X
C Z
B Z
B Y
A Y
B Z
B Y
A X
A X
A Y
A Y
A Y
B X
B Z
C Y
B X
B Z
A Y
A Y
A Y
A Y
B X
B Y
C Y
A Y
A Y
A Y
B Z
B Y
A Y
B X
B Z
A Y
A Y
A Y
A Y
B Y
A X
A X
B Z
B Y
C Y
B Z
B Z
A Y
A Y
B Z
A Y
B Z
C X
A Y
A Y
B Y
A Y
B Z
A Y
B Z
B Z
A Y
A Y
C Z
C Y
A Y
A Y
C Y
A Y
C Y
A Y
B Z
A Y
B X
A X
B Z
A Y
A Y
A Y
B Z
A Z
C Y
A Y
A Y
A Y
B X
B X
A Y
A Y
A X
A Y
B Y
B X
B X
A Y
A Y
C Y
A Z
A Y
B X
B X
B Z
A Y
A Y
B Y
C Y
B X
A Y
A Y
A Y
A Y
A X
B X
A Y
A Y
B Z
A X
C Y
B X
A Y
B Z
A Y
A Y
C Y
A Y
A X
A Y
A Y
B Z
A Y
C Z
A Y
B X
B X
B Y
B Z
A Y
A Y
A Y
B Z
A Y
B Z
A Y
A X
A Z
A Y
C Z
B X
A Y
B Z
B Y
A Y
B X
B Z
B Z
B Z
A Y
A X
B Y
B X
A Y
A Y
A Y
B X
A Y
A Y
B Z
A Y
C Y
B X
A Y
A Y
C Z
B Z
A Y
B Z
B Z
B Z
A Y
B Z
B Y
A Y
A Y
C Y
A Y
B Y
A Y
B X
A Y
C Z
A Y
B X
A X
A Y
A Y
B Z
A Y
B X
B Z
B X
A Y
A Y
A Y
A Y
B Z
A Y
B Z
A Y
A Y
C Y
A Y
C Y
B X
B X
A Y
A X
B Z
B X
A Y
A Y
A Y
A Y
B Y
C Y
A X
B X
A Y
C Y
B Y
A Y
B Y
B Z
A Y
B Z
B X
A Y
B X
A Y
C Y
A Y
B X
B Z
A Y
A Y
A Y
A X
A Y
A Z
C Z
A Y
B Z
A Y
B X
B X
A Y
C Y
C Y
A Y
A Y
B Y
A Y
C Z
B Z
C Y
B X
A Y
B Z
A Y
B X
C Y
B X
A Y
A Y
B X
B Z
A Y
B Z
C Y
B X
A Y
B Z
A Y
B Z
B Z
B Z
A Y
A Y
A Y"""
