class MyComponent extends HTMLElement {
  constructor(){
    super();
  }

  connectedCallback(){
    this.innerHTML = `
      <style>p { color: red; text-transform: uppercase;}</style>
      <p>My web component</p>
    `;
  } 
}

window.customElements.define("my-component", MyComponent);