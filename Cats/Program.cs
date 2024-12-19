using Cats;

// Example of a purebred cat
var grandParent1 = new Cat("GrandParent1", "Siamese");
var grandParent2 = new Cat("GrandParent2", "Siamese");
var parent1 = new Cat("Parent1", "Siamese", grandParent1, grandParent2);
var parent2 = new Cat("Parent2", "Siamese", grandParent1, grandParent2);
var purebredCat = new Cat("PurebredCat", "Siamese", parent1, parent2);

var purebredTree = new CatAncestryTree(purebredCat);
Console.WriteLine($"Is cat purebred? {purebredTree.IsPurebred()}");

// Example of a mixed breed cat
var grandParent3 = new Cat("GrandParent3", "Siamese");
var grandParent4 = new Cat("GrandParent4", "Persian");
var parent3 = new Cat("Parent3", "Siamese", grandParent3, grandParent4);
var parent4 = new Cat("Parent4", "Siamese", grandParent1, grandParent2);
var mixedBreedCat = new Cat("MixedBreedCat", "Siamese", parent3, parent4);

var mixedBreedTree = new CatAncestryTree(mixedBreedCat);
Console.WriteLine($"Is cat mixed breed? {mixedBreedTree.IsPurebred()}");