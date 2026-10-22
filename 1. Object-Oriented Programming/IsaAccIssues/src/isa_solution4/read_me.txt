Completely Composition over Inheritance with all inheritance
removed. The Withdrawable interface extends Account, so classes
only need implement one of these, plus when processing a list of
Withdrawable, each element can have getBalance() and deposit(...)
invoked, as that interface extends Account, rather than just the
withdraw(...) method.