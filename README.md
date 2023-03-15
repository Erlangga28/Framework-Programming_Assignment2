# Framework-Programming_Assignment2

## Erlangga Wahyu Utomo (5025201118)

### The Interface

> Create the Interface with grid and the button
```
 <Grid RowDefinitions="100, Auto, *"
          ColumnDefinitions=".75*, .25*"
          Padding="10"
          RowSpacing="10"
          ColumnSpacing="10">

        <Image Grid.ColumnSpan="2"
                Source="task1.jpg"
               BackgroundColor="Transparent"/>

        <Entry Placeholder="Enter task"
               Text="{Binding Text}"
               Grid.Row="1"/>

        <Button Text="Add"
                Command="{Binding AddCommand}"
                Grid.Row="1"
                Grid.Column="1"/>
```                

- The display will be like this
![Assignment_2](https://github.com/Erlangga28/Framework-Programming_Assignment2/blob/main/DataBinding-MVMM/Result/User-Interface.png)

## Add some text the student ID and Name <br />
- the text will be appear below
![Assignment_2](https://github.com/Erlangga28/Framework-Programming_Assignment2/blob/main/DataBinding-MVMM/Result/Input%20the%20data.png)

### Swipe in the right of the border and delete

- The delete button with the swipe item <br />
- The background color of button is red

```
<SwipeItem Text="Delete"
                                           BackgroundColor="Red"
                                           Command="{Binding Source={RelativeSource AncestorType={x:Type viewmodel:MainViewModel}}, Path=DeleteCommand}"
                                           CommandParameter="{Binding .}"/>
```

> Delete button will be like this
![Assignment_2](https://github.com/Erlangga28/Framework-Programming_Assignment2/blob/main/DataBinding-MVMM/Result/Swipe-Delete.png)
