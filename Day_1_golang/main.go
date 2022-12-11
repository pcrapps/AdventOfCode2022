package main

import (
	"bufio"
	"fmt"
	"os"
	"strconv"
)

func main() {
	input, _ := os.Open("elf.txt")
	defer input.Close()
	sc := bufio.NewScanner(input)

	maxCalories := 0
	currentElfCalories := 0

	for sc.Scan() {
		calories, err := strconv.Atoi(sc.Text())
		currentElfCalories += calories

		if err != nil {
			if currentElfCalories > maxCalories {
				maxCalories = currentElfCalories
			}
			currentElfCalories = 0
		}
	}
	fmt.Println(maxCalories)
}
