Imports LiveCharts
Imports LiveCharts.Wpf

Class MainWindow

    Public Property MySeriesCollection1 As New SeriesCollection
    Public Property MySeriesCollection2 As New SeriesCollection

    Public Property MyLabels1 As String() = {"A", "B", "C", "D"}
    Public Property MyLabels2 As String() = {"E", "F", "G", "H"}

    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded

        Dim iSeries As New StackedColumnSeries

        With iSeries
            .Values = New ChartValues(Of Integer)(New Integer() {25, 30, 40, 50})
            .StackMode = StackMode.Values
            .DataLabels = True
        End With
        MySeriesCollection1.Add(iSeries)

        iSeries = New StackedColumnSeries
        With iSeries
            .Values = New ChartValues(Of Integer)(New Integer() {25, 30, 40, 50})
            .StackMode = StackMode.Values
            .DataLabels = True
        End With
        MySeriesCollection2.Add(iSeries)

        iSeries = New StackedColumnSeries
        With iSeries
            .Values = New ChartValues(Of Integer)(New Integer() {2, 5, 6, 7})
            .StackMode = StackMode.Values
            .DataLabels = True
        End With
        MySeriesCollection1.Add(iSeries)

        iSeries = New StackedColumnSeries
        With iSeries
            .Values = New ChartValues(Of Integer)(New Integer() {2, 5, 6, 7})
            .StackMode = StackMode.Values
            .DataLabels = True
        End With
        MySeriesCollection2.Add(iSeries)

    End Sub

End Class
