```mermaid

classDiagram
    class IView{
        <<Interface>>
    }
    class PlayerOrder{
        <<Enumeration>>
    }
    class IComparable{
        <<Interface>>
    }
    class IComparer{
        <<Interface>>
    }

    IView <|.. UglyView
    IComparable <|.. Player
    IComparer <|.. CompareByName    

    CompareByName ..> Player

    Controller o-- Player
    Controller --> IComparer
    Controller --> IView
    Controller ..> PlayerOrder

    IView ..> Player

    UglyView o-- Player
    UglyView ..> PlayerOrder
    UglyView --> Controller
    
```