Domain Model

Class       | Attribute                 | Method          | Output
------------|---------------------------|-----------------|--------------------------------------
Basket      | products List IProduct    | add             | Boolean success or fail
            |                           | remove          | Boolean success or fail
            |                           | getTotal        | Int total cost of basket
            |                           | isInBasket      | Boolean item exists by name or not
            |                           | generateReceipt | String receipt for basket
=================================================================================================
Game        | name                      | getName         | String name of the game
            | price                     | getPrice        | Int price of the game
=================================================================================================
Drink       | name                      | getName         | String name of the drink
            | price                     | getPrice        | Int price of the drink
=================================================================================================
Book        | name                      | getName         | String name of the book
            | price                     | getPrice        | Int price of the book
=================================================================================================
IProduct    | The interface itself      | getName         | String name of the product
            |                           | getPrice        | Int price of the product
--------------------------------------------------------------------------------------------------            