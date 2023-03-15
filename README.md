# Framework-Programming_Assignment2

## Erlangga Wahyu Utomo (5025201118)

### Add text and click add to display
![Assignment_2]()

### The text will be appear in below
![Assignment_2]()

### swipe in the right of the border and delete
![Assignment_2]()

- The delete button with the swipe item

```
<SwipeItem Text="Delete"
                                           BackgroundColor="Red"
                                           Command="{Binding Source={RelativeSource AncestorType={x:Type viewmodel:MainViewModel}}, Path=DeleteCommand}"
                                           CommandParameter="{Binding .}"/>
```
