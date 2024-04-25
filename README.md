# Prog_122_L6_Notes_Week4
ComboBox
```xml
<ComboBox
            x:Name="cmbNames"
            Canvas.Left="471"
            Canvas.Top="118"
            Width="259"
            HorizontalAlignment="Left"
            VerticalAlignment="Center" />
```


ListBox
```xml
<ListBox
            d:ItemsSource="{d:SampleData ItemCount=5}"
            Margin="120,52,422,0"
            Height="217"
            VerticalAlignment="Top" />
```
Create class Person
change internal to public
person class
-fields 
    -first name
    -last name
-constructor
-property
-overide the toString
    -first and last name
    $"{firstName} {lastName":
