class RwStarRating extends HTMLElement {
  constructor(){
    super();

    this._root = this.attachShadow({mode: 'open'});
    this._$top = null;
    this._$bottom = null;

    // Data
    this._disabled = false;
    this._value = 0;
  }

  set value(val){
    if(this._value === val) return;
    this._value = val;
    this._render();
  }

  get value() {
    return this._value;
  }

  connectedCallback() {
    this._root.innerHTML = `
      <style>
        :host {
          width: 4.1em;
          height: 1em;
          display: inline-block;
          overflow: hidden;
          user-select: none;
          vertical-align: middle;
          box-sizing: border-box;
        }
        
        .container {
          color: #c5c5c5;
          font-size: 1em;
          line-height: 1em;
          margin: 0 auto;
          position: relative;
          padding: 0;
        }

        .container .top {
          color: #e7bd06;
          padding: 0;
          position: absolute;
          z-index: 1;
          display: block;
          top: 0;
          left: 0;
          overflow: hidden;
          width: 0;
        }

        .container: hover .top {
          display: none;
        }

        .container .bottom {
          padding: 0;
          display: block;
          position: absolute;
          top: 0;
          left: 0;
          unicode-bidi: bidi-override;
          direction: rtl;
        }

        .container .bottom > span:hover,
        .container .bottom > span:hover ~ span {
          color: #e7bd06;
        }

        :host([disabled]) .container {
          cursor: inherit;
        }

        :host([disabled]) .container .top {
          display: block;
        }

        :host([disabled]) .container .bottom > span:hover, 
        :host([disabled]) .container .bottom > span:hover ~ span {
          color: inherit;
        }

      </style>
      <div class="container">
        <div class="top">
          <span>★</span><span>★</span><span>★</span><span>★</span><span>★</span>
        </div>
        <div class="bottom">
          <span data-value="5">★</span><span data-value="4">★</span><span data-value="3">★</span><span data-value="2">★</span><span data-value="1">★</span>
        </div>
      </div>
    `;

    this._disabled = (this.getAttribute("disabled" !== null));
    this._$top = this._root.querySelector(".top");
    this._$bottom = this._root.querySelector(".bottom");
    this._$bottom.addEventListener('click', (event) => {
      console.log(event.target.dataset.value);
      if(this._disabled !== true && event.target.dataset.value !== undefined) {
        if(this._value != event.target.dataset.value) {
          this.dispatchEvent(new Event("change"));
          this.value = event.target.dataset.value;
          console.log(event.target.dataset.value);
        }
      }
    });
    this._render();
  }

  _render(){
    if(this._$top !== null){
      this._$top.style.width = ((this._value * 10) * 2) + "%";
    }
  }

  static get observedAttributes() {
    return ["disabled"];
  }

  attributeChangedCallback(name, oldValue, newValue){
    if( oldValue !== newValue) {
      switch (name) {
        case "disabled":
          this._disabled = newValue !== null;
          break;
      }
    }
  }

}

window.customElements.define("rw-star-rating", RwStarRating);